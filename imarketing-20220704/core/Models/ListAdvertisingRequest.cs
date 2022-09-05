// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListAdvertisingRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public ListAdvertisingRequestApp App { get; set; }
        public class ListAdvertisingRequestApp : TeaModel {
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public Dictionary<string, object> Ext { get; set; }

            [NameInMap("Mediaid")]
            [Validation(Required=false)]
            public string Mediaid { get; set; }

            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

        [NameInMap("Dealtype")]
        [Validation(Required=false)]
        public int? Dealtype { get; set; }

        [NameInMap("Device")]
        [Validation(Required=false)]
        public ListAdvertisingRequestDevice Device { get; set; }
        public class ListAdvertisingRequestDevice : TeaModel {
            [NameInMap("Androidid")]
            [Validation(Required=false)]
            public string Androidid { get; set; }

            [NameInMap("Androidmd5")]
            [Validation(Required=false)]
            public string Androidmd5 { get; set; }

            [NameInMap("Caid")]
            [Validation(Required=false)]
            public string Caid { get; set; }

            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            [NameInMap("Connectiontype")]
            [Validation(Required=false)]
            public int? Connectiontype { get; set; }

            [NameInMap("Devicetype")]
            [Validation(Required=false)]
            public int? Devicetype { get; set; }

            [NameInMap("Geo")]
            [Validation(Required=false)]
            public ListAdvertisingRequestDeviceGeo Geo { get; set; }
            public class ListAdvertisingRequestDeviceGeo : TeaModel {
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("District")]
                [Validation(Required=false)]
                public string District { get; set; }

                [NameInMap("Lat")]
                [Validation(Required=false)]
                public double? Lat { get; set; }

                [NameInMap("Lon")]
                [Validation(Required=false)]
                public double? Lon { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

            }

            [NameInMap("Idfa")]
            [Validation(Required=false)]
            public string Idfa { get; set; }

            [NameInMap("Imei")]
            [Validation(Required=false)]
            public string Imei { get; set; }

            [NameInMap("Imeimd5")]
            [Validation(Required=false)]
            public string Imeimd5 { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            [NameInMap("Macmd5")]
            [Validation(Required=false)]
            public string Macmd5 { get; set; }

            [NameInMap("Make")]
            [Validation(Required=false)]
            public string Make { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("Oaid")]
            [Validation(Required=false)]
            public string Oaid { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("Osv")]
            [Validation(Required=false)]
            public string Osv { get; set; }

            [NameInMap("Ua")]
            [Validation(Required=false)]
            public string Ua { get; set; }

            [NameInMap("Utdid")]
            [Validation(Required=false)]
            public string Utdid { get; set; }

        }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, object> Ext { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Imp")]
        [Validation(Required=false)]
        public List<ListAdvertisingRequestImp> Imp { get; set; }
        public class ListAdvertisingRequestImp : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Tagid")]
            [Validation(Required=false)]
            public string Tagid { get; set; }

        }

        [NameInMap("Test")]
        [Validation(Required=false)]
        public int? Test { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public ListAdvertisingRequestUser User { get; set; }
        public class ListAdvertisingRequestUser : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Usertype")]
            [Validation(Required=false)]
            public string Usertype { get; set; }

        }

    }

}
