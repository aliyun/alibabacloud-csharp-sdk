// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class VerifyAdvertisingRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public VerifyAdvertisingRequestApp App { get; set; }
        public class VerifyAdvertisingRequestApp : TeaModel {
            /// <summary>
            /// ext
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public Dictionary<string, object> Ext { get; set; }

            /// <summary>
            /// mediaid
            /// </summary>
            [NameInMap("Mediaid")]
            [Validation(Required=false)]
            public string Mediaid { get; set; }

            /// <summary>
            /// sn
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

        [NameInMap("Dealtype")]
        [Validation(Required=false)]
        public int? Dealtype { get; set; }

        /// <summary>
        /// device
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public VerifyAdvertisingRequestDevice Device { get; set; }
        public class VerifyAdvertisingRequestDevice : TeaModel {
            /// <summary>
            /// androidid
            /// </summary>
            [NameInMap("Androidid")]
            [Validation(Required=false)]
            public string Androidid { get; set; }

            /// <summary>
            /// androidmd5
            /// </summary>
            [NameInMap("Androidmd5")]
            [Validation(Required=false)]
            public string Androidmd5 { get; set; }

            /// <summary>
            /// Caid
            /// </summary>
            [NameInMap("Caid")]
            [Validation(Required=false)]
            public string Caid { get; set; }

            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            [NameInMap("Connectiontype")]
            [Validation(Required=false)]
            public int? Connectiontype { get; set; }

            /// <summary>
            /// deviceType
            /// </summary>
            [NameInMap("Devicetype")]
            [Validation(Required=false)]
            public int? Devicetype { get; set; }

            [NameInMap("Geo")]
            [Validation(Required=false)]
            public VerifyAdvertisingRequestDeviceGeo Geo { get; set; }
            public class VerifyAdvertisingRequestDeviceGeo : TeaModel {
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("District")]
                [Validation(Required=false)]
                public string District { get; set; }

                /// <summary>
                /// lat
                /// </summary>
                [NameInMap("Lat")]
                [Validation(Required=false)]
                public double? Lat { get; set; }

                /// <summary>
                /// lon
                /// </summary>
                [NameInMap("Lon")]
                [Validation(Required=false)]
                public double? Lon { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

            }

            /// <summary>
            /// Idfa
            /// </summary>
            [NameInMap("Idfa")]
            [Validation(Required=false)]
            public string Idfa { get; set; }

            /// <summary>
            /// imei
            /// </summary>
            [NameInMap("Imei")]
            [Validation(Required=false)]
            public string Imei { get; set; }

            /// <summary>
            /// imeimd5
            /// </summary>
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

            /// <summary>
            /// Macmd5
            /// </summary>
            [NameInMap("Macmd5")]
            [Validation(Required=false)]
            public string Macmd5 { get; set; }

            /// <summary>
            /// make
            /// </summary>
            [NameInMap("Make")]
            [Validation(Required=false)]
            public string Make { get; set; }

            /// <summary>
            /// model
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// oaid
            /// </summary>
            [NameInMap("Oaid")]
            [Validation(Required=false)]
            public string Oaid { get; set; }

            /// <summary>
            /// os
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// osv
            /// </summary>
            [NameInMap("Osv")]
            [Validation(Required=false)]
            public string Osv { get; set; }

            /// <summary>
            /// ua
            /// </summary>
            [NameInMap("Ua")]
            [Validation(Required=false)]
            public string Ua { get; set; }

            /// <summary>
            /// Utdid
            /// </summary>
            [NameInMap("Utdid")]
            [Validation(Required=false)]
            public string Utdid { get; set; }

        }

        /// <summary>
        /// ext
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, object> Ext { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// imp
        /// </summary>
        [NameInMap("Imp")]
        [Validation(Required=false)]
        public List<VerifyAdvertisingRequestImp> Imp { get; set; }
        public class VerifyAdvertisingRequestImp : TeaModel {
            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// tagid
            /// </summary>
            [NameInMap("Tagid")]
            [Validation(Required=false)]
            public string Tagid { get; set; }

        }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("Test")]
        [Validation(Required=false)]
        public int? Test { get; set; }

        /// <summary>
        /// user
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public VerifyAdvertisingRequestUser User { get; set; }
        public class VerifyAdvertisingRequestUser : TeaModel {
            /// <summary>
            /// uid
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// uidtype
            /// </summary>
            [NameInMap("Usertype")]
            [Validation(Required=false)]
            public string Usertype { get; set; }

        }

        [NameInMap("Verifyad")]
        [Validation(Required=false)]
        public List<VerifyAdvertisingRequestVerifyad> Verifyad { get; set; }
        public class VerifyAdvertisingRequestVerifyad : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Seat")]
            [Validation(Required=false)]
            public string Seat { get; set; }

        }

    }

}
