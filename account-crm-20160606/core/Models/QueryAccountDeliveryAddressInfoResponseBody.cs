// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAccountDeliveryAddressInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAccountDeliveryAddressInfoResponseBodyData> Data { get; set; }
        public class QueryAccountDeliveryAddressInfoResponseBodyData : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("AreaDivision")]
            [Validation(Required=false)]
            public QueryAccountDeliveryAddressInfoResponseBodyDataAreaDivision AreaDivision { get; set; }
            public class QueryAccountDeliveryAddressInfoResponseBodyDataAreaDivision : TeaModel {
                [NameInMap("DivisionAbbName")]
                [Validation(Required=false)]
                public string DivisionAbbName { get; set; }

                [NameInMap("DivisionId")]
                [Validation(Required=false)]
                public long? DivisionId { get; set; }

                [NameInMap("DivisionLevel")]
                [Validation(Required=false)]
                public long? DivisionLevel { get; set; }

                [NameInMap("DivisionName")]
                [Validation(Required=false)]
                public string DivisionName { get; set; }

                [NameInMap("DivisionTname")]
                [Validation(Required=false)]
                public string DivisionTname { get; set; }

                [NameInMap("NewDivisionId")]
                [Validation(Required=false)]
                public long? NewDivisionId { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("Pinyin")]
                [Validation(Required=false)]
                public string Pinyin { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("CityDivision")]
            [Validation(Required=false)]
            public QueryAccountDeliveryAddressInfoResponseBodyDataCityDivision CityDivision { get; set; }
            public class QueryAccountDeliveryAddressInfoResponseBodyDataCityDivision : TeaModel {
                [NameInMap("DivisionAbbName")]
                [Validation(Required=false)]
                public string DivisionAbbName { get; set; }

                [NameInMap("DivisionId")]
                [Validation(Required=false)]
                public long? DivisionId { get; set; }

                [NameInMap("DivisionLevel")]
                [Validation(Required=false)]
                public long? DivisionLevel { get; set; }

                [NameInMap("DivisionName")]
                [Validation(Required=false)]
                public string DivisionName { get; set; }

                [NameInMap("DivisionTname")]
                [Validation(Required=false)]
                public string DivisionTname { get; set; }

                [NameInMap("NewDivisionId")]
                [Validation(Required=false)]
                public long? NewDivisionId { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("Pinyin")]
                [Validation(Required=false)]
                public string Pinyin { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("CityId")]
            [Validation(Required=false)]
            public string CityId { get; set; }

            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public string Contacts { get; set; }

            [NameInMap("DefaultAddress")]
            [Validation(Required=false)]
            public bool? DefaultAddress { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("Postalcode")]
            [Validation(Required=false)]
            public string Postalcode { get; set; }

            [NameInMap("ProviceDivision")]
            [Validation(Required=false)]
            public QueryAccountDeliveryAddressInfoResponseBodyDataProviceDivision ProviceDivision { get; set; }
            public class QueryAccountDeliveryAddressInfoResponseBodyDataProviceDivision : TeaModel {
                [NameInMap("DivisionAbbName")]
                [Validation(Required=false)]
                public string DivisionAbbName { get; set; }

                [NameInMap("DivisionId")]
                [Validation(Required=false)]
                public long? DivisionId { get; set; }

                [NameInMap("DivisionLevel")]
                [Validation(Required=false)]
                public long? DivisionLevel { get; set; }

                [NameInMap("DivisionName")]
                [Validation(Required=false)]
                public string DivisionName { get; set; }

                [NameInMap("DivisionTname")]
                [Validation(Required=false)]
                public string DivisionTname { get; set; }

                [NameInMap("NewDivisionId")]
                [Validation(Required=false)]
                public long? NewDivisionId { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("Pinyin")]
                [Validation(Required=false)]
                public string Pinyin { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("ProviceId")]
            [Validation(Required=false)]
            public string ProviceId { get; set; }

            [NameInMap("TownDivision")]
            [Validation(Required=false)]
            public QueryAccountDeliveryAddressInfoResponseBodyDataTownDivision TownDivision { get; set; }
            public class QueryAccountDeliveryAddressInfoResponseBodyDataTownDivision : TeaModel {
                [NameInMap("DivisionAbbName")]
                [Validation(Required=false)]
                public string DivisionAbbName { get; set; }

                [NameInMap("DivisionId")]
                [Validation(Required=false)]
                public long? DivisionId { get; set; }

                [NameInMap("DivisionLevel")]
                [Validation(Required=false)]
                public long? DivisionLevel { get; set; }

                [NameInMap("DivisionName")]
                [Validation(Required=false)]
                public string DivisionName { get; set; }

                [NameInMap("DivisionTname")]
                [Validation(Required=false)]
                public string DivisionTname { get; set; }

                [NameInMap("NewDivisionId")]
                [Validation(Required=false)]
                public long? NewDivisionId { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("Pinyin")]
                [Validation(Required=false)]
                public string Pinyin { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("TownId")]
            [Validation(Required=false)]
            public string TownId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
