// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0.Models
{
    public class QueryDeviceListResponseBody : TeaModel {
        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public List<QueryDeviceListResponseBodyDeviceList> DeviceList { get; set; }
        public class QueryDeviceListResponseBodyDeviceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://XXXXXX">https://XXXXXX</a></para>
            /// </summary>
            [NameInMap("DeviceIconUrl")]
            [Validation(Required=false)]
            public string DeviceIconUrl { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jMR2********ojVJXk=</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            [NameInMap("DeviceUnionIds")]
            [Validation(Required=false)]
            public List<QueryDeviceListResponseBodyDeviceListDeviceUnionIds> DeviceUnionIds { get; set; }
            public class QueryDeviceListResponseBodyDeviceListDeviceUnionIds : TeaModel {
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("UnionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public string Online { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>125****0946</para>
        /// </summary>
        [NameInMap("EncodeKey")]
        [Validation(Required=false)]
        public string EncodeKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROJECT_ID</para>
        /// </summary>
        [NameInMap("EncodeType")]
        [Validation(Required=false)]
        public string EncodeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
