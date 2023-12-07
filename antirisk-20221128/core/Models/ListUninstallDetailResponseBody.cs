// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class ListUninstallDetailResponseBody : TeaModel {
        /// <summary>
        /// msg
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUninstallDetailResponseBodyData Data { get; set; }
        public class ListUninstallDetailResponseBodyData : TeaModel {
            [NameInMap("details")]
            [Validation(Required=false)]
            public List<ListUninstallDetailResponseBodyDataDetails> Details { get; set; }
            public class ListUninstallDetailResponseBodyDataDetails : TeaModel {
                [NameInMap("activeDatetime")]
                [Validation(Required=false)]
                public string ActiveDatetime { get; set; }

                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// deviceBrand
                /// </summary>
                [NameInMap("deviceBrand")]
                [Validation(Required=false)]
                public string DeviceBrand { get; set; }

                /// <summary>
                /// deviceModel
                /// </summary>
                [NameInMap("deviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                /// <summary>
                /// firstActiveDatetime
                /// </summary>
                [NameInMap("firstActiveDatetime")]
                [Validation(Required=false)]
                public string FirstActiveDatetime { get; set; }

                /// <summary>
                /// idfa
                /// </summary>
                [NameInMap("idfa")]
                [Validation(Required=false)]
                public string Idfa { get; set; }

                /// <summary>
                /// imei
                /// </summary>
                [NameInMap("imei")]
                [Validation(Required=false)]
                public string Imei { get; set; }

                /// <summary>
                /// installAppVersion
                /// </summary>
                [NameInMap("installAppVersion")]
                [Validation(Required=false)]
                public string InstallAppVersion { get; set; }

                /// <summary>
                /// installChannel
                /// </summary>
                [NameInMap("installChannel")]
                [Validation(Required=false)]
                public string InstallChannel { get; set; }

                /// <summary>
                /// oaid
                /// </summary>
                [NameInMap("oaid")]
                [Validation(Required=false)]
                public string Oaid { get; set; }

                /// <summary>
                /// osVersion
                /// </summary>
                [NameInMap("osVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// puid
                /// </summary>
                [NameInMap("puid")]
                [Validation(Required=false)]
                public string Puid { get; set; }

                [NameInMap("umid")]
                [Validation(Required=false)]
                public string Umid { get; set; }

                [NameInMap("uninstallCount")]
                [Validation(Required=false)]
                public int? UninstallCount { get; set; }

                [NameInMap("uninstallDatetime")]
                [Validation(Required=false)]
                public string UninstallDatetime { get; set; }

                /// <summary>
                /// zid
                /// </summary>
                [NameInMap("zid")]
                [Validation(Required=false)]
                public string Zid { get; set; }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
