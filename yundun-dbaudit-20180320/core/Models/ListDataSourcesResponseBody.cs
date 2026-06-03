// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyDbList> DbList { get; set; }
        public class ListDataSourcesResponseBodyDbList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuditSwitch")]
            [Validation(Required=false)]
            public int? AuditSwitch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 09:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DbAddresses")]
            [Validation(Required=false)]
            public List<string> DbAddresses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- ...... -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("DbCertificate")]
            [Validation(Required=false)]
            public string DbCertificate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds-a235dsdg2a****</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public int? DbType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mysql</para>
            /// </summary>
            [NameInMap("DbTypeName")]
            [Validation(Required=false)]
            public string DbTypeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("DbUsername")]
            [Validation(Required=false)]
            public string DbUsername { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5700</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public int? DbVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DbVersionName")]
            [Validation(Required=false)]
            public string DbVersionName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
