// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DataBusinessesValue : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        [NameInMap("Sname")]
        [Validation(Required=false)]
        public string Sname { get; set; }

        [NameInMap("SdkCodes")]
        [Validation(Required=false)]
        public List<DataBusinessesValueSdkCodes> SdkCodes { get; set; }
        public class DataBusinessesValueSdkCodes : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SellPrice")]
            [Validation(Required=false)]
            public string SellPrice { get; set; }

            [NameInMap("IceOpen")]
            [Validation(Required=false)]
            public int? IceOpen { get; set; }

            [NameInMap("SupportPlatform")]
            [Validation(Required=false)]
            public int? SupportPlatform { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public int? Authorized { get; set; }

            [NameInMap("AuthorizedApp")]
            [Validation(Required=false)]
            public List<string> AuthorizedApp { get; set; }

            [NameInMap("DefaultFeature")]
            [Validation(Required=false)]
            public string DefaultFeature { get; set; }

            [NameInMap("Integrate")]
            [Validation(Required=false)]
            public List<DataBusinessesValueSdkCodesIntegrate> Integrate { get; set; }
            public class DataBusinessesValueSdkCodesIntegrate : TeaModel {
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Pkg")]
                [Validation(Required=false)]
                public string Pkg { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            [NameInMap("Subscription")]
            [Validation(Required=false)]
            public string Subscription { get; set; }

            [NameInMap("ProductDesc")]
            [Validation(Required=false)]
            public string ProductDesc { get; set; }

            [NameInMap("SubscriptionPkg")]
            [Validation(Required=false)]
            public string SubscriptionPkg { get; set; }

            [NameInMap("SubscriptionImp")]
            [Validation(Required=false)]
            public string SubscriptionImp { get; set; }

        }

        [NameInMap("SdkFeatures")]
        [Validation(Required=false)]
        public List<DataBusinessesValueSdkFeatures> SdkFeatures { get; set; }
        public class DataBusinessesValueSdkFeatures : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Scode")]
            [Validation(Required=false)]
            public string Scode { get; set; }

            [NameInMap("Svalue")]
            [Validation(Required=false)]
            public string Svalue { get; set; }

        }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("IceOpen")]
        [Validation(Required=false)]
        public int? IceOpen { get; set; }

        [NameInMap("SupportPlatform")]
        [Validation(Required=false)]
        public int? SupportPlatform { get; set; }

        [NameInMap("FunctionDesc")]
        [Validation(Required=false)]
        public string FunctionDesc { get; set; }

        [NameInMap("ProductDesc")]
        [Validation(Required=false)]
        public string ProductDesc { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        [NameInMap("Authorized")]
        [Validation(Required=false)]
        public int? Authorized { get; set; }

        [NameInMap("AuthorizedApp")]
        [Validation(Required=false)]
        public List<string> AuthorizedApp { get; set; }

    }

}
